<?php

ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';

$productName = $_POST["productName"];
$productDescription = $_POST["description"];
$productPrice = $_POST["price"];

$db = connect(DBNAME);

addProduct($db, $productName, $productDescription, $productPrice);
include 'displayProductsPage.php';
?>