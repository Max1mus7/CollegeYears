<?php
require_once 'Person.php';
require_once 'Student.php';

$newGuy1 = new Person;
$newGuy2 = new Student;

$newGuy1->getOlderBy(2);
$newGuy2->getOlderBy(2);

echo "The age of person 1 is " . $newGuy1->age . ".<br>";
echo "The age of person 2 is " . $newGuy2->age . ".<br>";

?>