<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'session.php';
require_once 'myfuncs.php';

$sql = "SELECT * FROM users WHERE id = $id";
$result = $db->query($sql);
$row = $result->fetch_assoc();
$firstname = $row["firstname"];
$lastname = $row["lastname"];
$birthday = $row["birthday"];
$email = $row["email"];
$username = $row["username"];
$password = $row["password"];
$authority = $row["authority"];

echo "<form action='userEditHandler.php' method='post'>
        <ul>
            <li><b>First Name: </b><input type='text' name='firstname' value='$firstname' ></input></li>
            <li><b>Last Name: </b><input type='text' name='lastname' value='$lastname' ></input></li>
            <li><b>User ID: </b>$id</li>
            <li><b>Birthday: </b><input type='date' name='birthday' value='$birthday'></input></li>
            <li><b>Email: </b><input type='text' name='email' value='$email'></input></li>
            <li><b>Username: </b><input type='text' name='username' value='$username'></input></li>
            <li><b>Password: </b><input type='text' name='password' value='$password'></input></li>
            <li><b>Authority: </b><input type='text' name='authority' value='$authority'></input></li>
        </ul><hr>
        <input type='hidden' name='id' value='$id'></input>
        <input type='submit' name='submitted'></input>
        <input type='submit' name='delete' value='Delete'></input>
      </form>"
?>