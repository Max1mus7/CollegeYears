<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';

$db = connect(DBNAME);
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>User Display</title>
</head>
<link rel="stylesheet" href="styling.css">
<body>
	<div class="navbar">
	<ul>
		<li><a href="userRegistration.html">Register</a></li>
		<li><a href="userLogin.html">Login</a></li>
		<li><a href="displayProductsPage.php">View All Products</a></li>
		<li><a href="displayUsersPage.php">View Users</a></li>
	</ul>	
	</div>

</body>
</html>
<?php 
showUsers($db);
?>