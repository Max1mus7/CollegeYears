<!-- 
	Author: Max Weber
	File: loginHandler.php
	Description: This project is a PHP file that handles user input from loginPage.html,
	allows users to log in , and provides debugging for related processes
 --> 
<?php
//error reporting
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

//supply methods to aid in programming in an Object-Oriented fashion
require_once 'Cart.php';
require_once 'session.php';
require_once 'myfuncs.php';


//define global constants to allow connection to database and remove empty strings
define('EMPTY_STRING', "");

//allows for use of a message in loginfailed.php later
$message="";

//if connection successful, run "if" block. Otherwise run else block
if(!isset($_POST['submission']))
{
    die("Submission failed, no data received!");
}
else
{
    $password=$_POST['password'];
    $password=trim($password);
    $username=$_POST['username'];
    $username=trim($username);
    $dbname="cst-236";
}

$dbConnect = connect($dbname);

if($dbConnect)
{
    //select database
    if($dbConnect->select_db($dbname))
    //database successfully selected
    {
        //ensures that both the username and the password fields are adequately filled.
        if($username === NULL || $username === EMPTY_STRING)
        {
            echo "<p><b>Username</b> is a <em>required</em> field, it cannot be blank</p>
                  <br>
	              <br>
	              <br>
	              <a href='userLogin.html'>Return to Login</a>";
        }
        else if($password === NULL || $password === EMPTY_STRING)
        {
            echo "<p><b>Password</b> is a <em>required</em> field, it cannot be blank</p>
                  <br>
	              <br>
	              <br>
	              <a href='userLogin.html'>Return to Login</a>";
        }
        else
        {
            //connects to database and checks to see if a user with the input 
            //username and password exists inside
            $tableName = "users";
            $sql  = "SELECT firstname, lastname, ID, username, password
            FROM $tableName
            WHERE username='" . $username . "' AND password='" . $password . "'";
            if($result = $dbConnect->query($sql))
            {
                $numRows = $result->num_rows;
                if($numRows == 1)
                {
                    $row = $result->fetch_assoc();
                    setUserID($row['ID']);
                    $firstName = $row['firstname'];
                    $c = new Cart();
                    $_SESSION['cart'] = $c;
                    $_SESSION['pageNum'] = 0;
                    header("Location: http://localhost/Milestone%20Project/loginresponse.php", TRUE);
                    
                }
                else if($numRows == 0)
                {
                    $message="<p><em><strong>Login Failed.
                    </strong></em></p>";
                    include('loginfailed.php');
                }
            }
            else
            {
                echo "Error: " . $dbConnect->error . "<br>";
            }
        }
    }
    else
    //failed to select database
    {
        echo "<p>Could not select the " . $dbname . " database.
              Error:" . $dbConnect->error . "</p>";
    }
    //Outputs a statement and closes the connection
    $dbConnect->close();
}
else
{
    echo "<p>Connection error :" . $dbConnect->error . " </p>";
}
