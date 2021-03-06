<?php
require_once 'myfuncs.php';
require_once 'session.php';

class displayableProduct
{
    private $ID;
    private $name;
    private $description;
    private $price;
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
    }
    
    public function getID()
    {
        return $this->ID;
    }
    
    public function getName()
    {
        return $this->name;
    }
    
    public function getDescription()
    {
        return $this->description;
    }
    
    public function getPrice()
    {
        return $this->price;
    }
    
    public function displayProduct()
    {
        echo "<ul>
                <li><b>Name:</b> $this->name</li>
                <li><b>Product ID:</b> $this->ID</li>
                <li><b>Product Description:</b> $this->description</li>
                <li><b>Product Price:</b> $$this->price</li>
          </ul><hr>";
    }
    
    public function displayEditableProduct()
    {
        echo "<form action='productEditHandler.php' method='post'>
                <ul>
                    <li><b>Name: </b><input type='text' name='name' value='$this->name' ></input></li>
                    <li><b>Product ID: </b>$this->ID</li>
                    <li><b>Product Description: </b><input type='text' name='description' value='$this->description' </input></li>
                    <li><b>Product Price: </b><input type='text' name='price' value='$$this->price' </input></li>
                </ul><hr>
                <input type='hidden' name='id' value='$this->ID'></input>
                <input type='submit' name='submitted'></input>
                <input type='submit' name='delete' value='Delete'></input>
              </form>";   
    }
}

?>