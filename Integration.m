function [ X1 ] = Integration( data,deltaT )
%UNTITLED4 Summary of this function goes here
%   Detailed explanation goes here
N = length(data);
X1 = zeros(N,3);
for j = 2:N
   X1(j,:) = X1(j-1,:) + (data(j,:) + data(j-1,:))/2 * deltaT;
end
end

