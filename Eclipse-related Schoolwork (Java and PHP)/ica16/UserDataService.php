<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);
require_once 'Database.php';


class UserDataService
{
    
    
    function findByFirstName($param)
    {
        $database = new Database();
        $dbConnect = $database->getConnect();
        
        $sql = "SELECT * FROM users WHERE firstname LIKE '%$param%'";
        $result = $dbConnect->query($sql);
        $index = 0;
        $users = array();
        while($row = $result->fetch_assoc())
        {
            $users[$index] = array($row["id"], $row["firstname"], $row["lastname"]);
            ++$index;
        }
        return $users;
    }
    
}

?>