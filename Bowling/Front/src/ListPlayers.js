import React from ('react');
import axios from ('axios');

export default class ListPlayers extends React.Component {
    state = {
      persons: []
    }
  
    componentDidMount() {
      axios.get('http://localhost:8080/player')
        .then(res => {
          const players = res.data;
          this.setState({ players });
        })
    }
  
    render() {
      return (
        <ul>
          { this.state.players.map(players=> <li>{players.name}</li>)}
        </ul>
      )
    }
  }
