<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';





if(!isset($_GET["submitted"]))
{
    die("Submission failed, no data received");
}
else
{
    $db = connect(DBNAME);
    $id = $_GET["id"];
    include 'productPage.php';
}


?>