<?php
require_once 'CheckingAccountDataService.php';
require_once 'SavingsAccountDataService.php';
class BankBusinessService
{
    
    public function getCheckingBalance()
    {
        $db = mysqli_connect("localhost", "root", "root", "ica17");
        $this->c = new CheckingAccountDataService($db);
        return $this->c->getBalance()[1];
    }
    
    public function getSavingsBalance()
    {
        $db = mysqli_connect("localhost", "root", "root", "ica17");
        $this->s = new SavingsAccountDataService($db);
        return $this->s->getBalance()[1];
    }
    
    public function transaction()
    {
        $db = mysqli_connect("localhost", "root", "root", "ica17");
        $db->autocommit(FALSE);
        $this->c = new CheckingAccountDataService($db);
        $this->s = new SavingsAccountDataService($db);
        $db->begin_transaction();
        $initialChecking = $this->c->getBalance()[1];
        $check1 = $this->c->updateBalance($initialChecking-100);
        $initialSavings = $this->s->getBalance()[1];
        $check2 = $this->s->updateBalance($initialSavings+100);
        if($check1 == 1 && $check2 == 1)
        {
            $db->commit();
        }
        else
        {
            $db->rollback();
        }
    }
}
?>