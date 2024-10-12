from flask import Flask, request
import serial

app = Flask(__name__)
arduino = serial.Serial('COM3', 9600)  # Adjust COM port accordingly

@app.route('/led/<state>', methods=['GET'])
def led_control(state):
    if state == 'on':
        arduino.write(b'1')
        return 'LED is ON'
    elif state == 'off':
        arduino.write(b'0')
        return 'LED is OFF'
    else:
        return 'Invalid command'

if __name__ == '__main__':
    app.run(debug=True)
