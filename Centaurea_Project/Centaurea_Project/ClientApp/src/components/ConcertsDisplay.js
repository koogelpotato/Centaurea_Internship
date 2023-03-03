import React, { useState, useEffect } from "react";
import axios from "axios";

function ConcertList() {
    const [classicalConcerts, setClassicalConcerts] = useState([]);
    const [regularConcerts, setRegularConcerts] = useState([]);
    const [partyConcerts, setPartyConcerts] = useState([]);

    useEffect(() => {
        axios.get("/api/Concert/GetClassicalConcerts").then((response) => {
            setClassicalConcerts(response.data);
        });
        axios.get("/api/Concert/GetRegularConcerts").then((response) => {
            setRegularConcerts(response.data);
        });
        axios.get("/api/Concert/GetPartyConcerts").then((response) => {
            setPartyConcerts(response.data);
        });
    }, []);

    return (
        <div>
            <h2>Classical Concerts</h2>
            <ul>
                {classicalConcerts.map((concert) => (
                    <li key={concert.id}>{concert.title}</li>
                ))}
            </ul>
            <h2>Regular Concerts</h2>
            <ul>
                {regularConcerts.map((concert) => (
                    <li key={concert.id}>{concert.title}</li>
                ))}
            </ul>
            <h2>Party Concerts</h2>
            <ul>
                {partyConcerts.map((concert) => (
                    <li key={concert.id}>{concert.title}</li>
                ))}
            </ul>
        </div>
    );
}

export default ConcertList;