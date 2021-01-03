
<?php
require_once 'Car.php';
error_reporting(E_ALL);
ini_set('display_errors', 1);

$car = new Car();
echo "A car has been created.<br>";
if($car->getEngine()->getStartable())
{
    $car->start();
    echo "The car has been started<br>";
}

$car->go();
echo "The car is moving at ". $car->getSpeed() . " miles per hour<br>";

$car->stop();
echo "The car has stopped.";
?>

