<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);
require_once 'User.php';
$usersArr = array(
    new User(1, "Max", "Weber"),
    new User(2, "Kayla", "Currier"),
    new User(3, "Patrick", "Ulmer"),
    new User(4, "Randi", "Crawford"),
    new User(5, "Ivy", "Hale"),
);
$usersJSONArr = array();
for($i = 0; $i < 5; $i++)
{
    $usersJSONArr[] = $usersArr[$i]->jsonSerialize();
}

foreach($usersJSONArr as $output)
{
    
    foreach($output as $string)
    {
        echo $string . "<br>";
    }
    
}
?>