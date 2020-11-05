
<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);
require_once 'Tire.php';

class Engine
{
    private $tires;
    private $startable;
    
    public function checkTires()
    {
        foreach ($this->tires as $tire)
        {
            if($tire->getPSI() >= 32)
            {
                $this->startable = true;
            }
        }
    }
    public function __construct($tiresArr)
    {
        $this->tires = $tiresArr;
        $this->startable = false;
        $this->checkTires();
    }
    
    
    
    public function getStartable()
    {
        return $this->startable;
    }
}

?>