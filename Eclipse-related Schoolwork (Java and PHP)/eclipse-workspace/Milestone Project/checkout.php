<?php
//error reporting
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'Cart.php';
require_once 'myfuncs.php';
require_once 'session.php';



$db = connect(DBNAME);
$worked = confirmOrder();
if($worked)
{
    $c = $_SESSION['cart'];
    $c->clearCart();
    $_SESSION['cart'] = $c;
}
else {
    
}

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
		{
		echo "<li class='navigation'><a href='displayUsersPage.php'>View Users</a></li>
              <li class='navigation'><a href='salesReportPage.php'>View Sales</a></li>";
		}
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

if($worked)
{
    echo "<h2>Order succesful!</h2>
          <hr>
          <br>
          <br>
          <a href='displayProductsPage.php'>Shop for more products</a>";
    
}
else
{
    echo "<h1>Order failed.</h1>";
}

?>