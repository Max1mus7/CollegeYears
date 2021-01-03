<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'UserDataService.php';

//print_r($users);
for($i = 0; $i < count($users); $i++)
{
    echo "<tr>";

    echo "<td>" . $users[$i][0] . "</td><td>" . $users[$i][1] . "</td><td>" . $users[$i][2] . "</td>";
    echo "</tr>";
}
?>