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
define('MIN_POST_LENGTH', 5);

//require other classes
require_once 'displayableProduct.php';

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
    $userID = getUserID();
    $sql = "SELECT authority FROM users WHERE id = $userID";
    $result = $db->query($sql);
    $row = $result->fetch_assoc();
    $power = $row["authority"];
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
    if($pageNum < 0)
    {
        $pageNum = 0;
    }
    for($i = $pageNum*10 + 1; $i <= (1 + $pageNum)*10; $i++)
    {
        $sql = "SELECT * FROM products WHERE id = '" . $i . "'";
        $result = $db->query($sql);
        $row = $result->fetch_assoc();
        
        $pID = $row["id"];
        $pName = $row["productName"];
        $pDesc = $row["description"];
        $pPrice = $row["price"];
        if($pName===NULL)
        {
        }
        else 
        {
        echo "<form action='productPageHandler.php' method='GET'> 
                <tr>
                    <th><b>Name: $pName</b><br></th>
                </tr>
                    <td><br>Description: " . substr($pDesc, 0, 20) . "...<br></td>
                    <td>Price: $pPrice<br><br></td>
                <input type='hidden' name='id' value='" . $pID . "'>
                <input type='hidden' name='name' value='" . $pName . "'>
                <input type='hidden' name='description' value='" . $pDesc . "'>
                <input type='hidden' name='price' value='" . $pPrice . "'>
                <input type='submit' name='submitted' value='View Product Details'>
                <hr>
                </form>";
        }
    }
}

function showUsers($db)
{
    $userID = getUserID();
    $sql = "SELECT authority FROM users WHERE id = $userID";
    $result = $db->query($sql);
    $row = $result->fetch_assoc();
    $power = $row["authority"];
    
    $sql = "SELECT * FROM users";
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
                    <label for='email'>Email: </label>
                    <input type='text' name='email' value=''></input>
                    <label for='authority'>Authority: </label>
                    <input type='text' name='authority' value=''></input>
                    <br>
                    <br>
                    <label for='username'>Username: </label>
                    <input type='text' name='username' value=''></label>
                    <label for='password'>Password: </label>
                    <input type='text' name='password' value=''></label>
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
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
            break;
            
        case "price":
            $sql = "UPDATE products SET price = '".doubleval($input)."' WHERE id = $productID";
            if($result = $db->query($sql))
            {
                
            }
            else
            {
                echo $db->error;
            }
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

?>