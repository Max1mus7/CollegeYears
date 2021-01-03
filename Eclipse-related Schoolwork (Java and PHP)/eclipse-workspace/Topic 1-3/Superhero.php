<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);


class Superhero
{
    private $name;
    private $health;
    private $isDead;
    
    public function __construct($name, $health)
    {
        $this->name = $name;
        $this->health = $health;
        $this->isDead = false;
    }
    
    public function attack($superhero)
    {
        $superhero->determineHealth(rand(1,10));
    }
    
    public function determineHealth($damage)
    {
        $this->health -= $damage;
        if($this->health <= 0)
        {
            $this->health = 0;
            $this->isDead = true;
        }
    }
    
    public function getIsDead()
    {
        return $this->isDead;
    }
    
    public function getHealth()
    {
        return $this->health;
    }
}

?>