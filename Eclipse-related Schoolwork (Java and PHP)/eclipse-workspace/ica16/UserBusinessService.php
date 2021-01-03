<?php
ini_set('display_errors', '1');
ini_set('display_startup_errors', '1');
error_reporting(E_ALL);

require_once 'UserDataService.php';

class UserBusinessService
{
    function searchByFirstName($param)
    {
        $service = new UserDataService();
        return $service->findByFirstName($param);
    }
}
?>