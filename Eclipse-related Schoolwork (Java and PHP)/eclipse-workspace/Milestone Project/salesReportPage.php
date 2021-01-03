<?php 

ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'orderDetails.php';
require_once 'myfuncs.php';
require_once 'session.php';
$db = connect(DBNAME);
?>
<link rel="stylesheet" href="styling.css">
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
	<br>
	<form action="salesReportPage.php" method="post">
	<input type="date" name="dt1" value="Starting Date">
	<input type="date" name="dt2" value="Ending Date">
	<input type="submit" name="submitted" value="Show Sales">
	</form>
	<hr class="navigation">
<?php


if(isset($_POST['submitted']))
{
    $out = "";
    
    $dt1 = rearrange($_POST['dt1']);
    $dt2 = rearrange($_POST['dt2']);

$orderJSONArr = array();

echo "<h1>Sales Report</h1>
      <br>
      <hr>";

$sql = "SELECT * FROM orders WHERE date BETWEEN '" . $dt1 . "' AND '" . $dt2 . "' ORDER BY quantity DESC";
if($result1 = $db->query($sql))
{
    
}
else
{
    echo $db->error;
}
while($row1 = $result1->fetch_assoc())
{
    $id = $row1['id'];
    $sql = "SELECT * FROM orderdetails WHERE '" . $id . "' = orderID";
    $result = $db->query($sql);
while($row = $result->fetch_assoc())
{
    $orderDetails = new orderDetails();
    $orderDetails->id = $row['id'];
    $orderDetails->orderID = $row['orderID'];
    $orderDetails->productID = $row['productID'];
    $orderDetails->productQuantity = $row['productQuantity'];
    $orderDetails->currentPrice = $row['currentPrice'];
    $orderDetails->currentDescription = $row['currentDescription'];
    
    $orderJSONArr[] = $orderDetails;
    
}
}
$count = 0;
$_SESSION['orders'] = $orderJSONArr;
echo "<form action='salesReportJSONPage.php' method='POST'>
        <input type='submit' name='submitted' value='View JSON page'></input>
      </form>";
//header('Content-Type: application/json');
//echo json_encode($orderJSONArr, JSON_PRETTY_PRINT);


foreach($orderJSONArr as $output)
{
    
    foreach($output as $string)
    {
        if($count == 0)
        {
            echo "ID: ";
        }
        elseif ($count == 1)
        {
            echo "Order ID: ";
        }
        elseif ($count == 2)
        {
            echo "Product ID: ";
        }
        elseif ($count == 3)
        {
            echo "Product Quantity: ";
        }
        elseif ($count == 4)
        {
            echo "Price: ";
        }
        else
        {
            echo "Description: ";   
        }
        $out = $out . $string ."&#13;&#10;";
        echo $string . "<br>";
        $count++;
    }
    echo "<hr>";    
    $count = 0;
}

}
function rearrange($date)
{
    $date = str_replace("/", "-", $date);
    return $date;
}
?>