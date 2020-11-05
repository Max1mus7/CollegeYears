<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

define('HOSTNAME', "localhost");
define('USERNAME', "root");
define('PASSWORD', "root");
define('DB_NAME', "ica17");
class Database
{
    function getConnect()
    {
        $connection = mysqli_connect(HOSTNAME,USERNAME,PASSWORD,DB_NAME);
        
        return $connection;
    }
}

?>