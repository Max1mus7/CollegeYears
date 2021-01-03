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
		echo "<li class='navigation'><a href='displayUsersPage.php'>View Users</a></li>";
		echo "<li class='navigation'><a href='salesReportPage.php'>View Sales</a></li>";
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
if(!isset($_SESSION['pageNum']) && !isset($_POST['pageNum']))
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
    if(isset($_POST['pageNum']))
    {
        $pageNum = $_POST['pageNum'];
    }
    else if(isset($_SESSION['pageNum']))
    {
        $pageNum = $_SESSION['pageNum'];
    }
    if(isset($_POST['submit+']))
    {
        $pageNum++;
        $displayNum = $pageNum + 1;
        $_SESSION['pageNum'] = $pageNum;
        if(showProducts($db, $pageNum))
        {
            $_SESSION['pageNum'] = $pageNum - 1;
            header("Location: http://localhost/Milestone%20Project/displayProductsPage.php", TRUE);
        }
        echo    "<form action='displayProductsPage.php' method='POST'>
                <input type='submit' name='submit-' value=-1>
                <label>Page $displayNum </label>
                <input type='submit' name='submit+' value=+1>
                <input type='hidden' name='pageNum' value=$pageNum>";
    }
    else if(!isset($_POST['submit+']) && !isset($_POST['submit-']))
    {
        $pageNum = $_SESSION['pageNum'];
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
        $_SESSION['pageNum'] = $pageNum;
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
