<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';

if(!isset($_POST["submitted"]))
{
    die("Submission failed, no data received");
}
else
{
    $searched = $_POST['searched'];
    $db = connect(DBNAME);
    $sql = "SELECT * FROM products WHERE productName LIKE '%$searched%'";
    $result = $db->query($sql);
    while($row = $result->fetch_assoc())
    {
        displayProductPage($db, $row['id']);
    }
}

?>