#pragma once
#ifndef MATH_LIB_H
#define MATH_LIB_H


#ifdef __cplusplus
extern "C" {
#endif

#define SHARED_LIB __declspec(dllexport)


	double SHARED_LIB add(double a, double b);
	double SHARED_LIB subtract(double a, double b);
	double SHARED_LIB multiply(double a, double b);
	double SHARED_LIB divide(double a, double b);

#ifdef __cplusplus
	}
#endif

#endif
