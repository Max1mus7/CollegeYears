<?php
require_once 'Cart.php';
require_once 'session.php';
require_once 'myfuncs.php';


ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

//declares and instantiates important fields using POST from a displayableProduct object
$name = $_POST['name'];
$id = $_POST['id'];
$description = $_POST['description'];
$price = $_POST['price'];

//connect to database
$db = connect(DBNAME);

//deletes a product if the delete button is pressed
if(isset($_POST['delete']))
{
    deleteProduct($db, $id);
}
//adds a product to the cart using its ID
else if(isset($_POST['add']))
{
    //retrieves the user's cart using the session superglobal
    $c = $_SESSION['cart'];
    //addes the product to the cart
    $c->addItem($id);
    //overwrites the cart in the session superglobal
    $_SESSION['cart'] = $c;
}
else
{
//edits the values of the product
editProduct($db, $id, "name", $name);
editProduct($db, $id, "description", $description);
editProduct($db, $id, "price", $price);

echo "Product successfully edited!";
}
//returns the user to the page that displays all products
include 'displayProductsPage.php';

?>