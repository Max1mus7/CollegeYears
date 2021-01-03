<?php

class CheckingAccountDataService
{
    private $db; 
    public function __construct($db)
    {
        $this->db = $db;
    }
    public function getBalance()
    {
        $sql = "SELECT * FROM checking";
        $balances = [];
        if($result = $this->db->query($sql))
        {
            for($i = 0; $i < $result->num_rows; $i++)
            {
                $row = $result->fetch_assoc();
                $balances += [$row["ID"] => $row["BALANCE"]];
            }
            return $balances;
        }
        else
        {
             echo $this->db->error;
        }
    }
    
    public function updateBalance($balance)
    {
        $sql = "UPDATE checking SET BALANCE = $balance";
        if($result = $this->db->query($sql))
        {
            return 1;
        }
        else
        {
            echo $this->db->error;
        }
    }
}
?>