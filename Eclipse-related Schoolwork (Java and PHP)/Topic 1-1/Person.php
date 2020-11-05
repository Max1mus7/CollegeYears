<?php

class Person
{
    //properties of the class
    private $name;
    private $age;
    
    public function __construct($name, $age)
    {
        echo "Hello my name is ". $name . " and I am " . $age . " years old.<br>";
        $this->name = $name;
        $this->username = "Max";
        $this->password = "password";
    }
    
    public function walk()
    {
        echo "I am walking......." . "<br>";
    }
    
    public function formalGreeting()
    {
        echo "Good day to you sir. You can address me as " . $this->name . "<br>";
    }
    
    public function spanishGreeting()
    {
        echo "Hola. Me llamo " . $this->name . ".<br>";
    }
    
    public function login($username, $password)
    {
        if($username == $this->username && $password == $this->password)
        {
            echo $this->name . " has been logged in successfully!<br>";
        }
        else 
        {
            echo "Login failed. Please try again.";
        }
    }
}

?>