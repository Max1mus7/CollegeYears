<!-- 
	Author: Max Weber
	File: loginresponse.php
	Description: This project is a PHP form that shows the users their login was successful.
 -->
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
<title>Login Success</title>
<link rel="stylesheet" href="styling.css">
</head>
<body>
	<ul class="navigation">
		<li class="navigation"><a href="index.html">Return to Login</a>
		<li class="navigation"><a href="displayProductsPage.php">View All Products</a>
		<?php 
		$id = getUserID();
		$sql = "SELECT authority FROM users WHERE id = $id";
		$row = (($result = $db->query($sql))->fetch_assoc());
		$power = $row['authority'];
		if($power == 1)
		echo "<li class='navigation'><a href='displayUsersPage.php'>View Users</a></li>
              <li class='navigation'><a href='salesReportPage.php'>View Sales</a></li>";
		?>
	</ul>
</body>
</html>
<?php 

$sql = "SELECT firstname FROM users WHERE id = $id";
$row = (($result = $db->query($sql))->fetch_assoc());
$firstName = $row['firstname'];
echo "<p><h2><em><strong>Welcome back $firstName!</strong></em></h2></p>
                          <hr>" ;
?>