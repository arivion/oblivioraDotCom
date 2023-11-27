import React, { Component, createRef } from 'react';

export class EngageRandomizer extends Component {
    static displayName = EngageRandomizer.name;

    constructor(props) {
        super(props);
        this.state = {
            team: []
        }
    }

    handleSubmit = e => {
        // Prevent the browser from reloading the page
        e.preventDefault();

        // Read the form data
        const form = e.target;
        const formData = new FormData(form);
        fetch('api/engage/', { method: "POST", body: formData }).then(response => response.json()).then(response => this.setState({ team: response }));
    }

    static renderTeamTable(team) {
        if (!team) {    
            return (
                <div></div>
            );
        }

        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Character</th>
                        <th>Emblem</th>
                    </tr>
                </thead>
                <tbody>
                    {team.map(team =>
                        <tr key={team.character}>
                            <td>{team.character}</td>
                            <td>{team.emblem}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <table><tbody>
                        <tr>
                            <td><label className="check-label"> Number of units allowed in the party:<br></br></label></td>
                            <td><input type="number" name="units" id="units" className="check-input"
                                min="1" max="20" step="1" defaultValue="8"></input></td>
                        </tr>
                        <tr>
                            <td><label className="check-label"> Require Alear: </label></td>
                            <td><input type="checkbox" id="alear" name="alear" className="check-input"></input></td>
                        </tr>
                        <tr>
                            <td><label className="check-label"> Include DLC Emblems:</label></td>
                            <td><input type="checkbox" id="dlc" name="dlc" defaultChecked={true} className="check-input"></input></td>
                        </tr>
                        <tr>
                            <td><label className="check-label"> Fell Xenologue Complete: </label></td>
                            <td><input type="checkbox" id="fell" name="fell" className="check-input"></input></td>
                        </tr>
                        <tr>
                            <td><label className="check-label"> Current Chapter:</label></td>
                            <td><input type="number" name="chapter" id="chapter"
                                min="1" max="26" step="1" defaultValue="1" className="check-input"></input></td>
                        </tr></tbody></table>
                    <span>Assumes that all paralogues are completed ASAP! If you're using this and want to avoid spoilers ask Alex to make some tweaks.</span><hr />
                    <input type="submit" value="Submit" className="btn-primary"></input>
                        <br></br>
                </form>
                <hr />{EngageRandomizer.renderTeamTable(this.state.team)}
            </div>
        );
    }
}