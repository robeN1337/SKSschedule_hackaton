import React from 'react';
import { useState, useEffect } from 'react';
import "./ScheduleComponent.css";
//import './Raspisanie.css';

import axios from "axios"

import httpClient from "react-http-client"

const config = {
    headers: {
       "Access-Control-Allow-Origin": "*",
       "Access-Control-Allow-Methods": "GET,PUT,POST,DELETE,PATCH,OPTIONS"
    }
 };

function ScheduleComponent () {

const [users, setUsers] = useState();

// useEffect(() => {
//     getClick();
//   }, []);

    return (
    <center>
        <h1>Расписание</h1>
        <button onClick={getClick} style={{margin: "10px"}}>Получить пользователей</button>
        <button onClick={postClick} style={{margin: "10px"}}>Сделать пользователя</button>
        

        <table style={{border: "1px solid"}}>
        <thead>
            <tr style={{border: "2px solid"}}> 
                <th>GUID</th>
                <th>Username</th>
                <th>Email</th>
                <th>Password</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            {users?.map(user =>
                <tr key={user.guid}>
                    
                    <td>{user.guid}</td>
                    <td>{user.username}</td>
                    <td>{user.email}</td>
                    <td>{user.password}</td>
                    <th><button guidvalue={user.guid} onClick={async () => {
                        await axios.delete("http://localhost:5007/api/User/" + user.guid, config ).then(function deletedata(response) {
                            
                            console.log(response);
                        })
                    }}>Delete</button></th>
                </tr>
            )}
            
        </tbody>
    </table>
    </center>   
          
    );

    
    function postClick() {

        try {   
            httpClient.post("http://localhost:5007/api/User", {
                guid: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                username: "String",
                email: "string",
                password: "ffasfasdfas"
            }).then(response => {
                console.log(response);
            })
        } catch (error) {
            console.log(error);
        }
        
        // httpClient.post("http://localhost:5007/api/User", {
        //     guid: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        //     username: "String",
        //     email: "string",
        //     password: "ffasfasdfas"
        // }).then(response => {
        //     console.log(response);
        // })

        

    }


    function getClick() {

  

        httpClient.get("http://localhost:5007/api/User").then(function getdata(response) {
            setUsers(response);
          
          
    
          //console.log(response[4]["guid"])
          let users_list = [];
    
            response.map((user) => {
            //console.log(user.guid);
            users_list.push(user.guid);
            
            
          })
          console.log(users_list);
        })
      
        // const response = fetch("http://localhost:5007/api/User").then((response) => {
        //   const data = response.json();
        //   console.log(response[4]);
        // })
       
    }
    
}

export default ScheduleComponent;