<?php 
require_once 'myfuncs.php';
require_once 'session.php';

class displayableProduct
{
    //declares fields
    private $ID;
    private $name;
    private $description;
    private $price;
    private $url;
    private $formattedPrice;
    
    //only constructor, takes a product id
    public function __construct($productID)
    {
        $db = connect(DBNAME);
        $sql = "SELECT * FROM products WHERE id = '" . $productID . "'";
        $result = $db->query($sql);
        $row = $result->fetch_assoc();
        $this->name = $row["productName"];
        $this->description = $row["description"];
        $this->price = $row["price"];
        $this->ID = $productID;
        $this->url = $row["image"];
        $this->formattedPrice = $this->getFormattedPrice();
    }
    //product ID getter
    public function getID()
    {
        return $this->ID;
    }
    //product name getter
    public function getName()
    {
        return $this->name;
    }
    //product description getter
    public function getDescription()
    {
        return $this->description;
    }
    //product price getter
    public function getPrice()
    {
        return $this->price;
    }
    //product image getter
    public function getUrl()
    {
        return $this->url;
    }
    
    public function getFormattedPrice()
    {
        $displayPrice = "";
        $pPrice = $this->price;
        $priceArr = explode(".", $pPrice);
        if(count($priceArr) == 2)
        {
            if(strlen($priceArr[1]) == 2)
            {
                $displayPrice = "$" . $pPrice;
            }
            else
            {
                $displayPrice = "$" . $pPrice . 0;
            }
        }
        else
        {
            $displayPrice = "$" . $pPrice . ".00";
        }
        return $displayPrice;
    }
    
    //displays a product that the user is not able to edit
    public function displayProduct()
    {
        $db = connect(DBNAME);
        $cartItems = $_SESSION['cartItems'];
        echo "  <!DOCTYPE html>
                <html>
                <head>
                <meta charset='ISO-8859-1'>
                <title>Product Display</title>
                </head>
                <link rel='stylesheet' href='styling.css'>
                <body>
	               <ul class='navigation'>
		          <li class='navigation'><a href='index.html'>Return to Home</a></li>
		          <li class='navigation'><a href='displayProductsPage.php'>View All Products</a></li>
		          <li class='cart'><a href='cartPage.php'>View Cart ($cartItems)</a></li>
	              </ul>	
	              <br>
	              <br>
	              <form action='productSearchHandler.php' method='post'>
		          <label><b>Search:  </b></label>
		          <input type='text' name='searched'>
		          <input type='submit' name='submitted' value='Search'>
	           </form>
	       <br>
	       <hr class='navigation'>
        </body>
        </html>
        <div>
        <form action='productEditHandler.php' method='post'>
            <img src='$this->url' alt='No image found.' style='width:16em;height:16em;float:left;padding:2em;'>
                <ul style='display:inline;'>
                    
                    <li><b>Name:</b> $this->name</li>
                    <li><b>Product ID:</b> $this->ID</li>
                    <li><b>Product Description:</b> $this->description</li>
                    <li><b>Product Price:</b> $this->formattedPrice</li>
                </ul>
                </div>
                <br clear='all'>
                <input type='submit' name='add' value='Add to cart' style='margin-left:2.2em;'></input>
                <input type='hidden' name='id' value='$this->ID' style='clear:left;'></input>
                <input type='hidden' name='name' value='$this->name'></input>
                <input type='hidden' name='description' value='$this->description'></input>
                <input type='hidden' name='price' value='$this->price'></input>
                <a href='displayProductsPage.php' style='margin-left:2em;'>Return to previous page</a>
                <hr style='clear:left;'>
              </form>";
        
    }
    //displays a product that the user is able to edit
    public function displayEditableProduct()
    {
        $db = connect(DBNAME);
        $cartItems = $_SESSION['cartItems'];
        echo "  <!DOCTYPE html>
                <html>
                <head>
                <meta charset='ISO-8859-1'>
                <title>Product Display</title>
                </head>
                <link rel='stylesheet' href='styling.css'>
                <body>
	               <ul class='navigation'>
		          <li class='navigation'><a href='userRegistration.html'>Register</a></li>
		          <li class='navigation'><a href='userLogin.html'>Login</a></li>
		          <li class='navigation'><a href='displayProductsPage.php'>View All Products</a></li>
                  <li class='navigation'><a href='displayUsersPage.php'>View Users </a></li>
		          <li class='cart'><a href='cartPage.php'>View Cart ($cartItems)</a></li>
	              </ul>
	              <br>
	              <br>
	              <form action='productSearchHandler.php' method='post'>
		          <label><b>Search:  </b></label>
		          <input type='text' name='searched'>
		          <input type='submit' name='submitted' value='Search'>
	           </form>
	       <br>
	       <hr class='navigation'>
        </body>
        </html>
           <div>
                <form action='productEditHandler.php' method='post'>
                <img src='$this->url' alt='No image found.' style='width:16em;height:16em;float:left;padding:2em;'>
                <ul style='display:inline;'>
                    <li><b>Name: </b><input type='text' name='name' value='$this->name' ></input></li>
                    <li><b>Product ID: </b>$this->ID</li>
                    <li><b>Product Description: </b><input type='text' name='description' value='$this->description'> </input></li>
                </div>    
                <li><b>Product Price: $</b><input type='text' name='price' value='$this->price'> </input></li>
                </ul><hr style='clear:left;'>
                <input type='hidden' name='id' value='$this->ID'></input>
                <input type='submit' name='submitted'></input>
                <input type='submit' name='delete' value='Delete'></input>
                <input type='submit' name='add' value='Add to cart'></input>
              </form>";   
    }
}

?>