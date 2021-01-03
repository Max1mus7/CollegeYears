<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);
require_once 'UserBusinessService.php';


$firstName = $_POST['firstName'];

$UserBusinessService = new UserBusinessService();

$users = $UserBusinessService->searchByFirstName($firstName);

require_once '_displayAllUsers.php';
?>