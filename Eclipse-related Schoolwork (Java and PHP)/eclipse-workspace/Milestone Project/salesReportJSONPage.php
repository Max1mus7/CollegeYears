<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'orderDetails.php';
require_once 'myfuncs.php';
require_once 'session.php';

$orders = $_SESSION['orders'];

header('Content-Type: application/json');
echo json_encode($orders, JSON_PRETTY_PRINT);
?>