<?php

ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';

$firstname = $_POST["firstname"];
$lastname = $_POST["lastname"];
$email = $_POST["email"];
$birthday = $_POST["birthday"];
$username = $_POST["username"];
$password = $_POST["password"];
$authority = $_POST["authority"];

$db = connect(DBNAME);


addUser($db, $firstname, $lastname, $birthday, $email, $username, $password, $authority);
header("Location: http://localhost/Milestone%20Project/displayUsersPage.php", TRUE);
?>