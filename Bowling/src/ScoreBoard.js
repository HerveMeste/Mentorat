import Frame from './Frame';
import { useState } from 'react';


const ScoreBoard = () => {

  const [namePlayer, setNamePlayer] = useState('');
  const [player, setPlayer] = useState([]);

  const handleChange = (event) => {
    setNamePlayer([ event.target.value]);
  }

  const handleSubmit = (event) => {
    setPlayer(
      [...player, {name: namePlayer}]
      
    )     
    
    event.preventDefault();
  }

  return (
    <div className="scoreboard">
      <form onSubmit={handleSubmit}>
          <label>
            Name:
            <input type="text" value={namePlayer} onChange={handleChange} />
          </label>
          <input type="submit" value="Submit" />
      </form>
      
      <div className="frames">

        {player.map(person => (
          <div className="frames-content">
            <h1>{person.name}</h1>
            <Frame/>
            <Frame/>
            <Frame/>
            <Frame/>
            <Frame/>
            <Frame/>
            <Frame/>
            <Frame/>
            <Frame/>
            <Frame/>
          </div>
        ))}
      
      </div>
      <h1>Game Score = 0</h1>
    </div>
  );
};

export default ScoreBoard;