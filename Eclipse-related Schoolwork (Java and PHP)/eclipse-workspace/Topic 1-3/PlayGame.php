<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

require_once 'Superman.php';
require_once 'Batman.php';

$batman = new Batman();
$superman = new Superman();

while(!$batman->getIsDead() && !$superman->getIsDead())
{
    $superman->attack($batman);
    echo "Batman was attacked! His health is now " . $batman->getHealth() . ".<br>";
    if($batman->getHealth() <= 0)
    {
        echo "Batman is dead! Superman is the victor!";
    }
    else 
    {
        $superman->attack($batman);
        echo "Superman was attacked! His health is now " . $superman->getHealth() . ".<br>";
        if($superman->getHealth() <= 0)
        {
            echo "Superman is dead! Batman is the victor!";
        }
    }
    echo "<br>";
}
?>