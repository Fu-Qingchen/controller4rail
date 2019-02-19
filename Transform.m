% input: A0[ax,ay,az]:acceleration of x,y,z
% input: Theta[thetax,thetay,thetaz]:Inclination of x,y,z
% output: A1[ax,ay,az]:acceleration of x,y,z after remove the Gravitation acceleration
function [ A1 ] = Transform( A0,Theta )
%UNTITLED2 Summary of this function goes here
%   Detailed explanation goes here
x = Theta(1)*pi/180;y = Theta(2)*pi/180;z = Theta(3)*pi/180;

Tx1 = [1 0 0 0;
    0 cos(x) sin(x) 0;
    0 -sin(x) cos(x) 0;
    0 0 0 1];
Ty1 = [cos(y) 0 -sin(y) 0;
    0 1 0 0;
    sin(y) 0 cos(y) 0;
    0 0 0 1];
Tz1 = [cos(z) sin(z) 0 0;
    -sin(z) cos(z) 0 0;
    0 0 1 0;
    0 0 0 1];

Tx3 = [1 0 0 0;
    0 cos(-x) sin(-x) 0;
    0 -sin(-x) cos(-x) 0;
    0 0 0 1];
Ty3 = [cos(-y) 0 -sin(-y) 0;
    0 1 0 0;
    sin(-y) 0 cos(-y) 0;
    0 0 0 1];
Tz3 = [cos(-z) sin(-z) 0 0;
    -sin(-z) cos(-z) 0 0;
    0 0 1 0;
    0 0 0 1];

Atemp = [A0(1) A0(2) A0(3) 1];

T1 = Tx1*Ty1*Tz1;
T2 = [1 0 0 0;
    0 1 0 0;
    0 0 1 0;
    0 0 -1 1];
T3 = Tz3*Ty3*Tx3;

T = T1*T2*T3;
Atemp = Atemp*T;
A1 = Atemp(1:3);
end

