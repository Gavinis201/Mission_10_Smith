import { useEffect, useState } from "react";
import {Bowler} from "./types/bowler"

function BowlerList(){
    const [bowler, setBowler] = useState<Bowler[]>([])

    useEffect(() => {
        const fetchBowler = async () => {
            const response = await fetch("https://localhost:5000/Bowling")
            const data = await response.json();
            setBowler(data)
        };
        fetchBowler();
    }, []);


    return(
        <>
        <h1>Contact information for Bowlers</h1>
        <table>
            <thead>
                <tr>
                    <td>Bowler Name</td>
                    <td>Address</td>
                    <td>City</td>
                    <td>State</td>
                    <td>Zip</td>
                    <td>Phone Number</td>
                    <td>Team Name</td>
                </tr>
            </thead>
            <tbody>
                {
                    bowler.map((f)=> (
                        <tr key={f.bowlerId}>
                            <td>{`${f.bowlerFirstName} ${f.bowlerMiddleInit} ${f.bowlerLastName}`.trim()}</td>
                            <td>{f.bowlerAddress}</td>
                            <td>{f.bowlerCity}</td>
                            <td>{f.bowlerState}</td>
                            <td>{f.bowlerZip}</td>
                            <td>{f.bowlerPhoneNumber}</td>
                            <td>{f.teamId}</td>
                        </tr>
                    ))
                }
            </tbody>
        </table>
        
        </>
    );
}

export default BowlerList;