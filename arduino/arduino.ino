#include <AccelStepper.h>
#include <Servo.h>

#define MotorInterfaceType 8
#define motorMaxSpeed 1000
#define motorPin1 2      
#define motorPin2 3     
#define motorPin3 4     
#define motorPin4 5

#define sliderLeftPin 7
#define sliderRightPin 8

#define servoPin1 9
#define servoPin2 10
#define servoPin3 11
#define servoPin4 12


AccelStepper stepper = AccelStepper(MotorInterfaceType, motorPin1, motorPin3, motorPin2, motorPin4);
Servo serv1, serv2, serv3, serv4;
///////////////////////////////////////////////////////////////////////////////////////////////////////////

#define maxMoves 10
byte ms1[maxMoves]={255}, ms2[maxMoves]={255}, ms3[maxMoves]={255}, ms4[maxMoves]={255};
int mst[maxMoves]={0};

int currentMove = 0;
int totalMoves = 0;

///////////////////////////////////////////////////////////////////////////////////////////////////////////

void setup()
{
    Serial.begin(9600);
    
    stepper.setMaxSpeed(motorMaxSpeed);
  
    serv1.attach(servoPin1);
    serv2.attach(servoPin2);
    serv3.attach(servoPin3);
    serv4.attach(servoPin4);

    serv1.write(90);
    serv2.write(90);
    serv3.write(90);
    serv4.write(90);
}

void loop()
{   
    if (Serial.available() >= 2)
    {
        byte head = Serial.read();
        byte data = Serial.read();
        
       
        switch(head)
        {        
            case 0: //STOP
                Serial.write(0);
                break;
                
            case 255: //START
                Serial.write(255);
                break;

                      
            case 1: //servo 1
                serv1.write(data);
                break;
    
            case 2: //servo 2
                serv2.write(data);
                break;
    
            case 3: //servo 3
                serv3.write(data);
                break;
    
            case 4: //servo 4
                serv4.write(data);
                break;

                
            case 5: //steper left
                stepper.setSpeed(map(data, 1, 255, 1, 1000));
                while(Serial.available() < 2){ stepper.runSpeed(); delay(1); mst[currentMove]++;}
                break;
                
            case 6: //stepper stop
                break;
            
            case 7: //steper right
                stepper.setSpeed(-map(data, 1, 255, 1, 1000));
                while(Serial.available() < 2) { stepper.runSpeed(); delay(1); mst[currentMove]--;}
                break;

            case 8: //slide left
                digitalWrite(sliderLeftPin, 1);
                digitalWrite(sliderRightPin, 0);
                break;

            case 9: //slide stop
                digitalWrite(sliderLeftPin, 0);
                digitalWrite(sliderRightPin, 0);
                break;

            case 10: //slide right
                digitalWrite(sliderLeftPin, 0);
                digitalWrite(sliderRightPin, 1);
                break;
    
        }
      
    }
}
