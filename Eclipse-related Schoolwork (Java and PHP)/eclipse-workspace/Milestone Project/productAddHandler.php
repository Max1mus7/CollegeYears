<?php

ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';

$productName = $_POST["productName"];
$productDescription = $_POST["description"];
$productPrice = $_POST["price"];
if(count(preg_split(".", $productPrice)) > 2)
{
    echo "Please make sure you only have one \".\" in your price field.";
}
else 
{
    $db = connect(DBNAME);

    if(isset($_POST["submitted"]))
    {
        addProduct($db, $productName, $productDescription, $productPrice);
        foreach ($_POST as $i => $value)
        {
        unset($_POST[$i]);
        }
        $_POST = array_values($_POST);
    }
header("Location: http://localhost/Milestone%20Project/displayProductsPage.php", TRUE);
}
?>