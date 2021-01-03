<?php

require_once 'Dog.php';
require_once 'Cat.php';

$cat = new Cat("Morris", "Orange");
$dog = new Dog("Fido", "Black");

$cat->talk();
$dog->talk();

$cat->doTrick();
$dog->doTrick();