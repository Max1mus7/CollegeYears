<?php

ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';

$db = connect(DBNAME);
$id = $_POST["id"];
if(isset($_POST["delete"]))
{
    deleteUser($db, $id);
}
else
{
$firstname = $_POST["firstname"];
$lastname = $_POST["lastname"];
$email = $_POST["email"];
$birthday = $_POST["birthday"];
$username = $_POST["username"];
$password = $_POST["password"];
$authority = $_POST["authority"];
editUser($db, $id, "firstname", $firstname);
editUser($db, $id, "lastname", $lastname);
editUser($db, $id, "email", $email);
editUser($db, $id, "birthday", $birthday);
editUser($db, $id, "username", $username);
editUser($db, $id, "password", $password);
editUser($db, $id, "authority", $authority);
}
include('displayUsersPage.php');
?>