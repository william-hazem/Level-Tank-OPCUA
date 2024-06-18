
export enum MethodIds {
   BombaType_StartBomba = 'i=7001',
   BombaType_StopBomba = 'i=7002',
   TanqueType_BombaTanque_StartBomba = 'i=7005',
   TanqueType_BombaTanque_StopBomba = 'i=7006',
   Tanque1_BombaTanque_StartBomba = 'i=7003',
   Tanque1_BombaTanque_StopBomba = 'i=7004',
   Tanque2_BombaTanque_StartBomba = 'i=7007',
   Tanque2_BombaTanque_StopBomba = 'i=7008',
   Tanque3_BombaTanque_StartBomba = 'i=7009',
   Tanque3_BombaTanque_StopBomba = 'i=7010',
   Tanque4_BombaTanque_StartBomba = 'i=7011',
   Tanque4_BombaTanque_StopBomba = 'i=7012'
}

export enum ObjectIds {
   Tanque1 = 'i=5007',
   Tanque1_BombaTanque = 'i=5010',
   Tanque1_ControleVazao = 'i=5011',
   Tanque1_SensorTanque = 'i=5012',
   Tanque1_SensorTanque_BaseObject = 'i=5013',
   Tanque2 = 'i=5016',
   Tanque2_BombaTanque = 'i=5017',
   Tanque2_ControleVazao = 'i=5018',
   Tanque2_SensorTanque = 'i=5019',
   Tanque2_SensorTanque_BaseObject = 'i=5020',
   Tanque3 = 'i=5023',
   Tanque3_BombaTanque = 'i=5024',
   Tanque3_ControleVazao = 'i=5025',
   Tanque3_SensorTanque = 'i=5026',
   Tanque3_SensorTanque_BaseObject = 'i=5027',
   Tanque4 = 'i=5030',
   Tanque4_BombaTanque = 'i=5031',
   Tanque4_ControleVazao = 'i=5032',
   Tanque4_SensorTanque = 'i=5033',
   Tanque4_SensorTanque_BaseObject = 'i=5034'
}

export enum ObjectTypeIds {
   BombaType = 'i=1003',
   ControleType = 'i=1004',
   SensorType = 'i=1005',
   TanqueType = 'i=1006'
}

export enum VariableIds {
   Tanque1_BombaTanque_DL = 'i=6016',
   Tanque1_BombaTanque_EN = 'i=6017',
   Tanque1_BombaTanque_LG = 'i=6018',
   Tanque1_BombaTanque_ST = 'i=6020',
   Tanque1_BombaTanque_TRIP = 'i=6021',
   Tanque1_BombaTanque_VAL = 'i=6025',
   Tanque1_BombaTanque_YS = 'i=6036',
   Tanque1_ControleVazao_MV = 'i=6037',
   Tanque1_ControleVazao_PV = 'i=6038',
   Tanque1_ControleVazao_SP = 'i=6039',
   Tanque1_SensorTanque_Valor = 'i=6040',
   Tanque2_BombaTanque_DL = 'i=6041',
   Tanque2_BombaTanque_EN = 'i=6042',
   Tanque2_BombaTanque_LG = 'i=6043',
   Tanque2_BombaTanque_ST = 'i=6044',
   Tanque2_BombaTanque_TRIP = 'i=6045',
   Tanque2_BombaTanque_VAL = 'i=6046',
   Tanque2_BombaTanque_YS = 'i=6047',
   Tanque2_ControleVazao_MV = 'i=6048',
   Tanque2_ControleVazao_PV = 'i=6049',
   Tanque2_ControleVazao_SP = 'i=6050',
   Tanque2_SensorTanque_Valor = 'i=6051',
   Tanque3_BombaTanque_DL = 'i=6052',
   Tanque3_BombaTanque_EN = 'i=6053',
   Tanque3_BombaTanque_LG = 'i=6054',
   Tanque3_BombaTanque_ST = 'i=6055',
   Tanque3_BombaTanque_TRIP = 'i=6056',
   Tanque3_BombaTanque_VAL = 'i=6057',
   Tanque3_BombaTanque_YS = 'i=6058',
   Tanque3_ControleVazao_MV = 'i=6059',
   Tanque3_ControleVazao_PV = 'i=6060',
   Tanque3_ControleVazao_SP = 'i=6061',
   Tanque3_SensorTanque_Valor = 'i=6062',
   Tanque4_BombaTanque_DL = 'i=6063',
   Tanque4_BombaTanque_EN = 'i=6064',
   Tanque4_BombaTanque_LG = 'i=6065',
   Tanque4_BombaTanque_ST = 'i=6066',
   Tanque4_BombaTanque_TRIP = 'i=6067',
   Tanque4_BombaTanque_VAL = 'i=6068',
   Tanque4_BombaTanque_YS = 'i=6069',
   Tanque4_ControleVazao_MV = 'i=6070',
   Tanque4_ControleVazao_PV = 'i=6071',
   Tanque4_ControleVazao_SP = 'i=6072',
   Tanque4_SensorTanque_Valor = 'i=6073'
}

export class StatusCode {
   public static isGood(code?: number): boolean {
      return !code || (code & 0xD0000000) === 0;
   }
   public static isUncertain(code?: number): boolean {
      return (code ?? 0 & 0x40000000) !== 0;
   }
   public static isBad(code?: number): boolean {
      return (code ?? 0 & 0x80000000) !== 0;
   }
}