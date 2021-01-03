<?php

/*
 Author: Max Weber
 File: myfuncs.php
 
 Description: A PHP file that holds common functions for other classes to call upon
 */

//set timezone
ini_set( 'date.timezone', 'America/Phoenix' );

//error reporting
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

define('HOST_NAME', "localhost", true);
define('USER_NAME', "root", true);
define('PASSWORD', "root", true);
define('DBNAME', "cst-236", true);

//require other classes
require_once 'displayableProduct.php';
require_once 'Cart.php';
require_once 'session.php';


//function that establishes a connection to a database
function connect($dbName)
{
$dbConnect = new mysqli(HOST_NAME,USER_NAME,PASSWORD,$dbName);
if($dbConnect->connect_error)
{
    echo "<p>Connection error :" . $dbConnect->error . " </p>";
}
return $dbConnect;
}

//changes the user ID for the current session
function setUserID($id)
{
    $_SESSION['userID'] = $id;
}

//returns the user ID for the current session
function getUserID()
{
    return $_SESSION['userID'];
}

//shows all products in the database
function showProducts($db, $pageNum)
{
    //boolean to make sure that there are results on the page
    $wrong = FALSE;
    //determines the user's authority using the userID held in $_SESSION
    $userID = getUserID();
    $sql = "SELECT authority FROM users WHERE id = $userID";
    //queries database and returns a mysqli object
    $result = $db->query($sql);
    //turns mysqli object into an associative array
    $row = $result->fetch_assoc();
    //determines the authority of the user and assigns that value to power variable
    $power = $row["authority"];
    //if the user is an admin, display a form with the ability to add a new product
    if($power == 1)
    {
        echo "<form action='productAddHandler.php' method='POST'>
                <h3><b>Create a new product here!</b></h3>
                    <label for='productName'>Product name: </label>
                    <input type='text' name='productName' value=''></input>
                    <label for='description'>Description: </label>
                    <input type='text' name='description' value=''></input>
                    <label for='price'>Price: $</label>
                    <input type='text' name='price' value='0.00'></input>
                    <input type='submit' name='submitted' value='Create Product'></input>
                </form><br><br><hr>";
    }
    //ensures that the page number would never go lower than 0
    if($pageNum < 0)
    {
        $pageNum = 0;
    }
        //offset determines where products are taken from the database
        $offset = $pageNum*2;
        //takes 2 
        $sql = "SELECT * FROM products 
                ORDER BY id ASC 
                LIMIT 2 OFFSET $offset";
        $result = $db->query($sql);
        for($i = 0; $i < $result->num_rows; $i++)
        {
        $row = $result->fetch_assoc();
        
        $pID = $row["id"];
        $pName = $row["productName"];
        $pDesc = $row["description"];
        $pPrice = $row["price"];
        $pImage = $row["image"];
        $displayPrice = "";
        $priceArr = explode(".", $pPrice);
        if(count($priceArr) == 2)
        {
            if(strlen($priceArr[1]) == 2)
            {
                $displayPrice = "$" . $pPrice;
            }
            else 
            {
                $displayPrice = "$" . $pPrice . 0;
            }
        }
        else 
        {
            $displayPrice = "$" . $pPrice . ".00";
        }
        if($pName===NULL)
        {
        }
        else if($result->num_rows > 0)
        {
        echo "  <img src='$pImage' alt='Image not found.' style='width:100px;height:100px;'>
                <form action='productPageHandler.php' method='GET'> 
                <tr>
                    <th><b>Name: $pName</b><br></th>
                </tr>
                    <td><br>Description: " . substr($pDesc, 0, 20) . "...<br></td>
                    <td>Price: $displayPrice<br><br></td>
                <input type='hidden' name='id' value='" . $pID . "'>
                <input type='hidden' name='name' value='" . $pName . "'>
                <input type='hidden' name='description' value='" . $pDesc . "'>
                <input type='hidden' name='price' value='" . $pPrice . "'>
                <input type='submit' name='submitted' value='View Product Details'>
                <hr>
                </form>";
        }
        }
        if($result->num_rows == 0)
        {
            $wrong = TRUE;
        }
        return $wrong;
}

//shows all users in the database
function showUsers($db)
{
    $userID = getUserID();
    $sql = "SELECT authority FROM users 
            WHERE id = $userID";
    $result = $db->query($sql);
    $row = $result->fetch_assoc();
    $power = $row["authority"];
    
    $sql = "SELECT * FROM users 
            ORDER BY id ASC 
            LIMIT 10";
    $result = $db->query($sql);
    if($power == 1)
    {
    echo "<form action='userAddHandler.php' method='POST'>
                <h3><b>Create a new user here!</b></h3>
                    <label for='firstname'>First name: </label>
                    <input type='text' name='firstname' value=''></input>
                    <label for='lastname'>Last name: </label>
                    <input type='text' name='lastname' value=''></input>
                    <label for='birthday'>Birthday: </label>
                    <input type='date' name='birthday' value=''></input>
                    <br>
                    <br>
                    <label for='email'>Email: </label>
                    <input type='text' name='email' value=''></input>
                    <label for='username'>Username: </label>
                    <input type='text' name='username' value=''></label>
                    <label for='password'>Password: </label>
                    <input type='text' name='password' value=''></label>
                    <br>
                    <br>
                    <label for='authority'>Authority: </label>
                    <input type='text' name='authority' value=''></input>
                    <br>
                    <br>
                    <input type='submit' name='submitted' value='Create User'></input>
                </form><br><br><hr>";
    }
    
    while ($row = $result->fetch_assoc())
    {
        $userID = $row["id"];
        $userName = $row["firstname"];
        $userLastName = $row["lastname"];
        $userAuthority = $row["authority"];
        $userBirthday = $row["birthday"];
        $userEmail = $row["email"];
        if($power == 1)
        {
        echo "  
                <form action='userEditPageHandler.php' method='POST'>
                <tr>
                    <th><b>Name: $userName $userLastName</b><br></th>
                </tr>
                    <td><br>Birthday: $userBirthday<br></td>
                    <td><br>Email: $userEmail<br></td>
                    <td>Authority: $userAuthority<br><br></td>
                <input type='hidden' name='id' value=$userID></input>
                <input type='submit' name='submitted' value='View User Details'>
                <hr>
                </form>";
        }
        else 
        {
            echo "<form action='userEditPageHandler.php' method='POST'>
                <tr>
                    <th><b>Name: $userName</b><br></th>
                </tr>
                    <td><br>First Name: $userName<br></td>
                    <td><br>Last Name: $userLastName<br></td>
                <input type='hidden' name='id' value=$userID></input>
                <input type='submit' name='submitted' value='View User'>
                <hr>
                </form>";
        }
    }
    
}

//displays a specific user
function displayUserPage($db, $id)
{
    $userID = getUserID();
    $sql = "SELECT * FROM users WHERE id = $userID";
    $result = $db->query($sql);
    $row = $result->fetch_assoc();
    $power = $row["authority"];
    if($power == 1 || $userID == $id)
    {
        include('userEditPage.php');
    }
    else
    {
        include('userViewPage.php');
    }
}

//displays a specific product 
function displayProductPage($db, $id)
{
    $userID = getUserID();
    $sql = "SELECT authority FROM users WHERE id = $userID";
    $result = $db->query($sql);
    $row = $result->fetch_assoc();
    $power = $row["authority"];
    $p = new displayableProduct($id);
    if($power == 1)
    {
        $p->displayEditableProduct();
    }
    else
    {
        $p->displayProduct();
    }
          
}

//adds a product into the database
function addProduct($db, $productName, $productDescription, $productPrice)
{
    $sql = "INSERT INTO products (productName, description, price) VALUES ('".$productName."', '".$productDescription."', '".$productPrice."')";
    if($result = $db->query($sql))
    {
        echo "Product successfully added!";
    }
    else
    {
        echo $db->error;
    }
}

//deletes a product in the database
function deleteProduct($db, $productID)
{
    $sql = "DELETE FROM products WHERE id = $productID";
    if($result = $db->query($sql))
    {
        echo "Product successfully deleted!";
    }
    else 
    {
        echo $db->error;
    }
}

//edits a product in the database
function editProduct($db, $productID, $inputQuery, $input)
{
    switch ($inputQuery)
    {
        case "name":
            $sql = "UPDATE products SET productName = '".$input."' WHERE id = $productID";
            $db->query($sql);
            break;
            
        case "description":
            $sql = "UPDATE products SET description = '".$input."' WHERE id = $productID";
            $db->query($sql);
            break;
            
        case "price":
            $sql = "UPDATE products SET price = '".doubleval($input)."' WHERE id = $productID";
            $db->query($sql);
            break;
            
        default:
            echo "<h2>Improper input detected. <a href = 'displayProductsPage.php'>Try Again</a></h2>";
            break;
    }
}

//adds a user into the database
function addUser($db, $firstname, $lastname, $birthday, $email, $username, $userpassword, $userauthority)
{
    $sql = "INSERT INTO users (firstname, lastname, birthday, email, username, password, authority)
            VALUES ('".$firstname."', '".$lastname."', '".$birthday."', '".$email."', '".$username."', '".$userpassword."', '".$userauthority."')";
    if($result = $db->query($sql))
    {
        echo "User successfully added!";
    }
    else 
    {
        echo $db->error;
    }
}

//deletes a user in the database
function deleteUser($db, $userID)
{
    $sql = "DELETE FROM users WHERE id = $userID";
    if($result = $db->query($sql))
    {
        echo "User successfully deleted";
    }
}

//edits a user in the database
function editUser($db, $id, $inputQuery, $input)
{
    switch($inputQuery)
    {
        case "firstname":
            $sql = "UPDATE users SET firstname = '".$input."' WHERE id = $id";
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
            
            break;
            
        case "lastname":
            $sql = "UPDATE users SET lastname = '".$input."' WHERE id = $id";
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
            break;
            
        case "birthday":
            $sql = "UPDATE users SET birthday = '".$input."' WHERE id = $id";
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
            break;
        case "email":
            $sql = "UPDATE users SET email = '".$input."' WHERE id = $id";
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
            break;
        case "username":
            $sql = "UPDATE users SET username = '".$input."' WHERE id = $id";
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
            break;
        case "password":
            $sql = "UPDATE users SET password = '".$input."' WHERE id = $id";
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
            break;
        case "authority":
            $sql = "UPDATE users SET authority = '".$input."' WHERE id = $id";
            if($result = $db->query($sql))
            {
                echo "User successfully edited!";
            }
            else
            {
                echo $db->error;
            }
            break;
        default:
            echo "<h2>Improper input detected. <a href = 'userDisplayPage.php'>Try Again</a></h2>";
            break;
    }
}

function addOrder($db)
{
    $userID = getUserID();
    $sql = "INSERT INTO orders (userID) VALUES ('".$userID."')";
    $db->query($sql);
    $sql = "SELECT id FROM orders
            ORDER BY id DESC
            LIMIT 1";
    $row = $db->query($sql)->fetch_assoc();
    $orderNum = $row['id'];
    return $orderNum;
}

function addOrderDetails($db, $orderID)
{
    $db = connect(DBNAME);
    $cart = $_SESSION['cart'];
    $worked = 1;
    $totalqty = 0;
    for($i = 0; $i < $cart->getNumItems(); $i++)
    {
        $id = $cart->getProductsIDArray()[$i];
        $product = new displayableProduct($id);
        $qty = $cart->getProductsQuantityArray()[$i];
        $totalqty += $qty;
        $price = $product->getPrice()*$qty;
        $description = $product->getDescription();
        $sql = "INSERT INTO orderdetails (`orderID`, `productID`, `productQuantity`, `currentPrice`, `currentDescription`) VALUES ('".$orderID."', '".$id."', '".$qty."', '".$price."', '".$description."')";
        if($result = $db->query($sql))
        {
            $worked = 0;
            
        }
        else
        {
            echo $db->error;
        }
        
    }
    return $worked;
}

function confirmOrder()
{
    $db = connect(DBNAME);
    $db->autocommit(FALSE);
    $db->begin_transaction();
    $orderID = addOrder($db);
    if(addOrderDetails($db, $orderID) == 0)
    {
        $db->commit();
        $db->autocommit(TRUE);
        $sql = "SELECT productQuantity FROM orderdetails WHERE orderID = '". $orderID . "'";
        $row = $db->query($sql)->fetch_assoc();
        $total = $row['productQuantity'];
        $sql = "UPDATE orders SET quantity = '". $total . "' WHERE id = '". $orderID . "'";
        $db->query($sql);
        return TRUE;
    }
    else
    {
        $db->rollback();
        return FALSE;
    }
}
?>