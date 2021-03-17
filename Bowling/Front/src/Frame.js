import React, { useState } from 'react';


const Frame = () => {

  const [inputOne, setInputOne] = useState("");
  const [inputSecond, setInputSecond] = useState("");

  const handleChangeOne = (event) => {
    setInputOne(event.target.value);
  }

  const handleChangeSecond = (event) => {
    setInputSecond(event.target.value);
  }

  const a = parseInt(inputOne);
  const b = parseInt(inputSecond);
  const total = (a, b) => {
    if(a + b > 10){
      return 10
    }else{
      return a + b 
    }
  }
  
const res = total(a, b);

  
  return (
    <form className="frame" >
      <span>
      <select value={inputOne} onChange={handleChangeOne} id="score1">
        <option value="0">0</option>
        <option value="1">1</option>
        <option value="2">2</option>
        <option value="3">3</option>
        <option value="4">4</option>
        <option value="5">5</option>
        <option value="6">6</option>
        <option value="7">7</option>
        <option value="8">8</option>
        <option value="9">9</option>
        <option value="10">X</option>
      </select>
      </span>
      <span>
        <select value={inputSecond} onChange={handleChangeSecond} id="score2" >
        <option value="0">0</option>
        <option value="1">1</option>
        <option value="2">2</option>
        <option value="3">3</option>
        <option value="4">4</option>
        <option value="5">5</option>
        <option value="6">6</option>
        <option value="7">7</option>
        <option value="8">8</option>
        <option value="9">9</option>
        <option value="10">/</option>
        </select>
      </span>
      <p>{res}</p>
    </form>
    );
    
};


export default Frame;