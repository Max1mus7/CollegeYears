<?php

final class Person
{
    public $name;
    public $age;
    
    public function getOlderBy($year)
    {
        $this->age += $year;
    }
}
?>