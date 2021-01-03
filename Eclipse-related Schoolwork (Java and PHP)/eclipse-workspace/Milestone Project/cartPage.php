<?php 


//requires necessary files
require_once 'Cart.php';
require_once 'displayableProduct.php';
require_once 'myfuncs.php';
require_once 'session.php';

$db = connect(DBNAME);

//error reporting
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Product Display</title>
</head>
<link rel="stylesheet" href="styling.css">
<body>
	<ul class="navigation">
		<li class="navigation"><a href="userRegistration.html">Register</a></li>
		<li class="navigation"><a href="userLogin.html">Login</a></li>
		<li class="navigation"><a href="displayProductsPage.php">View All Products</a></li>
		<?php 
		$id = getUserID();
		$sql = "SELECT authority FROM users WHERE id = $id";
		$row = (($result = $db->query($sql))->fetch_assoc());
		$power = $row['authority'];
		if($power == 1)
		echo "<li class='navigation'><a href='displayUsersPage.php'>View Users</a></li>"
		?>
		<li class="cart"><a href="cartPage.php">View Cart (<?php echo $_SESSION['cartItems']?>)</a></li>
	</ul>	
	<br>
	<br>
	<form action="productSearchHandler.php" method="post">
		<label><b>Search:  </b></label>
		<input type="text" name="searched">
		<input type="submit" name="submitted" value="Search">
	</form>
	<br>
	<hr>
</body>
</html>
<?php 
$c = $_SESSION['cart'];
$totalPrice = 0;
for($i = 0; $i < $c->getNumItems(); $i++)
{
    $p = new displayableProduct($c->getProductsIDArray()[$i]);
    $name = $p->getName();
    $description = $p->getDescription();
    $id = $p->getID();
    $price = $p->getPrice();
    $image = $p->getUrl();
    $qty = $c->getProductsQuantityArray()[$i];
    $totalPrice = $totalPrice + $price*$qty;
    //displayed individual item price
    $dIPrice = "";
    //displayed total item price
    $dTPrice = "";
    //format individual item price
    $dIPriceArr = explode(".", $price);
    if(count($dIPriceArr) == 2)
    {
        if(strlen($dIPriceArr[1]) == 2)
        {
            $dIPrice = "$" . $price;
        }
        else
        {
            $dIPrice = "$" . $price . 0;
        }
    }
    else
    {
        $dIPrice = "$" . $price . ".00";
    }
    //format total item price
    $dTPriceArr = explode(".", ($price*$qty));
    if(count($dTPriceArr) == 2)
    {
        if(strlen($dTPriceArr[1]) == 2)
        {
            $dTPrice = "$" . ($price*$qty);
        }
        else
        {
            $dTPrice = "$" . ($price*$qty) . 0;
        }
    }
    else
    {
        $dTPrice = "$" . ($price*$qty) . ".00";
    }
    echo "<img src='$image' alt='Image not found.' style='width:150px;height:150px;padding:20px;float:left;'> 
                <ul style='display:inline;'>
                    <li><b>Name:</b> $name</li>
                    <li><b>Product Description:</b> $description</li>
                    <li><b>Product Price:</b> $dIPrice</li>
                    <li><b>Quantity:</b> $qty</li>
                    <li><b>Total Price:</b> $dTPrice</li>
                </ul><hr style='clear:left;'>
                <input type='hidden' name='id' value='$id'></input>";
}
$priceArr = explode(".", $totalPrice);
if(count($priceArr) == 2)
{
    if(strlen($priceArr[1]) == 2)
    {
        $displayPrice = "$" . $totalPrice;
    }
    else
    {
        $displayPrice = "$" . $totalPrice . 0;
    }
}
else
{
    $displayPrice = "$" . $totalPrice . ".00";
}
echo "<h3>Total Price: $displayPrice</h3>
      <br>
      <br>
      <form action='checkoutHandler.php' method='POST'>
      <input type='hidden' name='tPrice' value='" . $totalPrice . "'>
      <input type='submit' name='submitted' value='Checkout'>
      <br>
      <br>
          <a href='displayProductsPage.php'>Return to previous page</a>";
?>