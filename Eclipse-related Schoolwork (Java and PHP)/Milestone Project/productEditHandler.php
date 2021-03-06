<?php

require_once 'session.php';
require_once 'myfuncs.php';

//error reporting
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

$name = $_POST['name'];
$id = $_POST['id'];
$description = $_POST['description'];
$price = $_POST['price'];

$db = connect(DBNAME);

if(isset($_POST['delete']))
{
    deleteProduct($db, $id);
}
else
{

editProduct($db, $id, "name", $name);
editProduct($db, $id, "description", $description);
editProduct($db, $id, "price", doubleval(substr($price, 1)));

echo "Product successfully edited!";
}
include 'displayProductsPage.php';

?>