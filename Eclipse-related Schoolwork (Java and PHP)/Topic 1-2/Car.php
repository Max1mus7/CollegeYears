<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

require_once 'Engine.php';
class Car
{
    private $tiresArr;
    private $engine;
    private $started;
    private $speed;
    
    public function __construct()
    {
        $this->tiresArr = array($tire1 = new Tire(), 
            $tire2 = new Tire(),
            $tire3 = new Tire(),
            $tire4 = new Tire());
        $this->engine = new Engine($this->tiresArr);  
        $this->started = false;
        $this->speed = 0;
    }
    
    public function getEngine()
    {
        return $this->engine;
    }
    
    public function getSpeed()
    {
        return $this->speed;
    }
    
    public function start()
    {
        if($this->engine->getStartable())
        {
            $this->started = true;
        }
    }
    
    public function go()
    {
        if($this->started)
        {
            $this->speed = 45;
        }
    }
    
    public function stop()
    {
        $this->started = false;
        $this->speed = 0;
    }
}
?>
