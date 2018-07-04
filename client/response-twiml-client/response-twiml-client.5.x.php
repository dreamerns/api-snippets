<?php
// Get the PHP helper library from https://twilio.com/docs/libraries/php

// this line loads the library 
require('vendor/autoload.php'); 
use Twilio\TwiML;

$response = new TwiML;

// get the phone number from the page request parameters, if given
if (isset($_REQUEST['To'])) {
    $number = htmlspecialchars($_REQUEST['To']);
    $dial = $response->dial(array('callerId' => '+15017122661'));
    
    // wrap the phone number or client name in the appropriate TwiML verb
    // by checking if the number given has only digits and format symbols
    if (preg_match("/^[\d\+\-\(\) ]+$/", $number)) {
        $dial->number($number);
    } else {
        $dial->client($number);
    }
} else {
    $response->say("Thanks for calling!");
}

echo $response;
