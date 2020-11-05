<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);
define('DB_USERNAME', 'root');
define('DB_PASSWORD', 'root');
define('DB_HOST', 'localhost');
define('DB_DATABASE', 'cst-236');
define('TABLE_NAME', 'users');

if(isset($_POST['submitted']))
{
    
    $username = $_POST['username'];
    $password = $_POST['password'];
    
    $connect = mysqli_connect(DB_HOST, DB_USERNAME, DB_PASSWORD, DB_DATABASE);
    
    if(!mysqli_connect_error())
    {
        echo "Database connection successful<br>";
        $sql = "INSERT INTO '" . TABLE_NAME . "' (username, password) VALUES('". $username . "'," . $password . "'";
        $result = mysqli_query($connect, $sql);
        echo "Registration successful!<br>";
        $connect->close();
        
    }
    else
    {
        die("Connection error:". mysqli_connect_error());
    }
}


?>