<?php
require_once 'Animal.php';

class Dog extends Animal
{
    public function talk()
    {
        echo "Bark! Bark!<br>";
    }
    
    public function doTrick()
    {
        echo "Jumps. Fetches. Does anything else you like.<br>";
    }
}