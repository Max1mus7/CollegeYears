<?php
//error checking
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

//requires necessary files once
require_once 'session.php';
require_once 'myfuncs.php';

//connects to database
$db = connect(DBNAME);
?>

<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>User Display</title>
</head>
<link rel="stylesheet" type="text/css" href="styling.css"/>
<body>
<!-- Shows navigation bar -->
	<ul class="navigation">
		<li class="navigation"><a href="userRegistration.html">Register</a></li>
		<li class="navigation"><a href="userLogin.html">Login</a></li>
		<li class="navigation"><a href="displayProductsPage.php">View All Products</a></li>
		<li class='navigation'><a href='salesReportPage.php'>View Sales</a></li>";
		<li class="cart"><a href="cartPage.php">View Cart (<?php echo $_SESSION['cartItems']?>)</a></li>
	</ul>	

</body>
</html>

<?php 
//shows users
showUsers($db);
?>