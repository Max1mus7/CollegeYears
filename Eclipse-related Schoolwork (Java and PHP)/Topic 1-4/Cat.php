<?php

require_once 'Animal.php';

class Cat extends Animal
{
    public function talk()
    {
        echo "Meow<br>";
    }
    
    public function doTrick()
    {
        echo "You gotta be kidding me.<br>";
    }
}