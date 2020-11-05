 <!-- 
	Author: Max Weber
	File: infoHandler.php
	Description: This project is a PHP file that handles user input from userRegistration.html,
	allows users to register, and provides debugging for related processes
 -->
 <?php
//error reporting
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1'); 
error_reporting(E_ALL);

//Require certain other files
include('myfuncs.php');

//define global constants to allow connection to database and remove empty strings
define('EMPTY_STRING', "");

//if connection successful, run "if" block. Otherwise run else block
if(!isset($_POST['submission']))
{
    die("Submission failed, no data received!");
}
else
{
    
    $firstName = $_POST['firstName'];
    $lastName = $_POST['lastName'];
    $firstName = trim($firstName);
    $lastName = trim($lastName);
    $birthday = $_POST['birthday'];
    $email = $_POST['email'];
    $username = $_POST['username'];
    $userPassword = $_POST['password'];
    $email = trim($email);
    $username = trim($username);
    $userPassword = trim($userPassword);
    //ensures that a user's password is properly entered
    if(trim($_POST['confirmPassword']) !== $userPassword)
    {
        include('registrationFailed.html');
        die();
    }
    $dbName = "cst-236";
}
//connect to database
$dbConnect = connect($dbName);

if($dbConnect)
{
    //select database
    if($dbConnect->select_db($dbName))
    //database successfully selected
    {
            if($firstName === NULL || $firstName === EMPTY_STRING)
            {
                echo "<p><b>First Name</b> is a <em>required</em> field, it cannot be blank</p>";
            }
            else if($lastName === NULL || $lastName === EMPTY_STRING)
            {
                echo "<p><b>Last Name</b> is a <em>required</em> field, it cannot be blank</p>";
            }
            else if($email === NULL || $email === EMPTY_STRING)
            {
                echo "<p><b>E-mail Address</b> is a <em>required</em> field, it cannot be blank</p>";
            }
            else if($username === NULL || $username === EMPTY_STRING)
            {
                echo "<p><b>Username</b> is a <em>required</em> field, it cannot be blank</p>";
            }
            else if($userPassword === NULL || $userPassword === EMPTY_STRING)
            {
                echo "<p><b>Password</b> is a <em>required</em> field, it cannot be blank</p>";
            }
            else
            {
                //ensures multiple users with the same username/password are not created
                $tableName = "users";
                $sql  = "SELECT firstName, ID, username, password
                        FROM $tableName
                        WHERE username='" . $username .
                        "' AND password='" . $userPassword . "'";
                if($result = $dbConnect->query($sql))
                {
                    $numRows = $result->num_rows;
                   
                    if($numRows == 0)
                    {
                        $sql  = "INSERT INTO $tableName (firstName, lastName, birthday, email, username,
                                password) VALUES('$firstName', '$lastName', '$birthday', '$email',
                                '$username', '$userPassword')";
                        if($result = $dbConnect->query($sql))
                        {
                            echo "<p>Regsistration Successful!\nWe're happy to have you, $firstName!</p>";
                            echo "<ul><li><a href='index.html'>Return to Login</a></li></ul>";
                        }
                        else
                        {
                            echo "Error: " . $dbConnect->error . "<br>";
                        }
                    }
                    else 
                    {
                        echo "<h2><strong>There is already a user with that information<strong></h2>";
                        echo "<ul><li><a href='userRegistration.html'>Return to Registration Page</a></li></ul>";
                        echo "<ul><li><a href='index.html'>Return to Login</a></li></ul>";
                    }
                }
                else
                {
                    echo "Error: " . $dbConnect->error;
                }
            }
    }
    else
    //failed to select database
    {
        echo "<p>Could not select the " . $dbName . " database.
                 Error:" . $dbConnect->error . "</p>";
    }
    $dbConnect->close();
}
else
{
    echo "<p>Connection error :" . $dbConnect->error . " </p>";
}
?>