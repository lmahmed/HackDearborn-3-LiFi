import React from 'react';

const LED = () => {
  const controlLED = (state) => {
    fetch(`http://127.0.0.1:5000/led/${state}`)
      .then(response => response.text())
      .then(data => alert(data))
      .catch(error => console.error('Error:', error));
  };

  return (
    <div>
      <h1>LED Control</h1>
      <button onClick={() => controlLED('on')}>ON</button>
      <button onClick={() => controlLED('off')}>OFF</button>
    </div>
  );
};

export default LED;
