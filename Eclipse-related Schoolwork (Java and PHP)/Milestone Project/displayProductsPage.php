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
<title>Product Display</title>
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
if(!isset($_POST['pageNum']))
{
   $pageNum = 0;
   showProducts($db, $pageNum);
   $displayNum = $pageNum + 1;
   echo    "<form action='displayProductsPage.php' method='POST'>
            <input type='submit' name='submit-' value=-1>
            <label>Page $displayNum </label>
            <input type='submit' name='submit+' value=+1>
            <input type='hidden' name='pageNum' value=$pageNum>";
}
else 
{
    $pageNum = $_POST['pageNum'];
    if(isset($_POST['submit+']))
    {
        $pageNum++;
        $displayNum = $pageNum + 1;
        showProducts($db, $pageNum);
        echo    "<form action='displayProductsPage.php' method='POST'>
                <input type='submit' name='submit-' value=-1>
                <label>Page $displayNum </label>
                <input type='submit' name='submit+' value=+1>
                <input type='hidden' name='pageNum' value=$pageNum>";
    }
    else
    {
        $pageNum--;
        if($pageNum < 0)
        {
            $pageNum = 0;
        }
        $displayNum = $pageNum + 1;
        showProducts($db, $pageNum);
        echo    "<form action='displayProductsPage.php' method='POST'>
                <input type='submit' name='submit-' value=-1>
                <label>Page $displayNum </label>
                <input type='submit' name='submit+' value=+1>
                <input type='hidden' name='pageNum' value=$pageNum>";
    }
}


            
?>
