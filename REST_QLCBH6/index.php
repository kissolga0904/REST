<?php
include("connection.php");

$db = new dbObj();
$connection = $db->getConnection();
$request_method = $_SERVER["REQUEST_METHOD"];
$username = "Olga";
$password = "123";

switch($request_method){
    case 'GET':         
        if(!empty($_GET["id"])){
            $id = intval($_GET["id"]);
            get_car_by_id($id);
        }else
            get_all_cars();
    break;
    
    case 'POST':
        insert_car();       
    break;
    
    case 'PUT': 
        update_car();
    break;
    
    case 'DELETE': 
        $id = intval($_GET["id"]);
        delete_car($id);
    break;
    
    default:
        header("HTTP/1.0 405 Method Not Allowed");
    break;
}
    


function get_all_cars(){
    global $connection;
    $query = "SELECT * FROM auto";

    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_assoc($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);
}

function get_car_by_id($id=0){
    global $connection;
    $query = "SELECT * FROM auto";
    if($id != 0) $query.= " WHERE id =" . $id . " LIMIT 1"; 
    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_assoc($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);

}

function insert_car(){
    global $connection;
    global $username;
    global $password;
    $data = json_decode(file_get_contents('php://input'), true);

    $requsername = $data["username"];
    $reqpassword = $data["password"];
    if($requsername == $username && $reqpassword == $password){

        $tulajdonos = $data["tulajdonos"];
        $marka = $data["marka"];
        $tipus = $data["tipus"];
        $szin = $data["szin"];
        $rendszam = $data["rendszam"];
    
        $query="INSERT INTO auto SET tulajdonos='".$tulajdonos."', marka='".$marka."', tipus='".$tipus."', szin='".$szin."', rendszam='".$rendszam."'";
    
        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Car inserted successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Car insertion failed'
            );
        }
    
        
        header('Content-Type: application/json');
           
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Car insertion unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }
    echo json_encode($response); 

}


function update_car(){
    global $connection;
    global $username;
    global $password;
    $data = json_decode(file_get_contents('php://input'),true);
    
    $requsername = $data["username"];
    $reqpassword = $data["password"];
    if($requsername == $username && $reqpassword == $password){
        $tulajdonos = $data["tulajdonos"];
        $marka = $data["marka"];
        $tipus = $data["tipus"];
        $szin = $data["szin"];
        $rendszam = $data["rendszam"];
        $id = intval($data["id"]);

        $query = "UPDATE auto SET tulajdonos='".$tulajdonos."', marka='".$marka."', tipus='".$tipus."', szin='".$szin."', rendszam='".$rendszam."' WHERE id = '".$id."'";

        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Car updated successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Car update failed'
            );
        }
        
        header('Content-Type: application/json'); 
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Car update unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }
    echo json_encode($response);    
}

function delete_car($id){
    global $connection;
    global $username;
    global $password;
    $data = json_decode(file_get_contents('php://input'), true);

    $requsername = $data["username"];
    $reqpassword = $data["password"];  

    if($requsername == $username && $reqpassword == $password){
        $query= "DELETE FROM auto WHERE id = ".$id;
        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Car deleted successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Car deletion failed'
            );
        }
           header('Content-Type: application/json');
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Car deletion unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }

    
    echo json_encode($response);
}