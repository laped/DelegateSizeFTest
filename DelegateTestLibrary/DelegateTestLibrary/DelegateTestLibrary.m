//
//  DelegateTestLibrary.m
//  DelegateTestLibrary
//
//  Created by Lasse Pedersen on 8/17/12.
//  Copyright (c) 2012 Lasse Pedersen. All rights reserved.
//

#import "DelegateTestLibrary.h"

@implementation DelegateTestLibrary

@synthesize dataSource = _dataSource;

- (CGSize)getSizeTest
{
    CGSize size = [_dataSource getSizeForMyTest];
    NSLog(@"getSizeTest - width=%f - height=%f", size.width, size.height);
    return size;
}

- (void)setDataSource:(NSObject<MyTestDataSource> *)dataSource
{
    _dataSource = dataSource;
}

@end
