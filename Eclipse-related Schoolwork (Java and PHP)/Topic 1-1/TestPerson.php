<?php
require_once 'Person.php';

$person = new Person("Max", 19);
$person->walk();

$person2 = new Person("Randi", 22);
$person2->formalGreeting();

$person3 = new Person("Jamie", 40);
$person3->spanishGreeting();

$person3->login("Max", "Wrong Password");
$person3->login("Max", "password");
?>