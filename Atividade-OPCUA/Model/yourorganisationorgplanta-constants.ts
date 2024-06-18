
export enum MethodIds {
   BombaType_StartBomba = 'i=7001',
   BombaType_StopBomba = 'i=7002',
   TanqueType_BombaTanque_StartBomba = 'i=7005',
   TanqueType_BombaTanque_StopBomba = 'i=7006',
   Tanque1_BombaTanque_StartBomba = 'i=7003',
   Tanque1_BombaTanque_StopBomba = 'i=7004'
}

export enum ObjectIds {
   Tanque1 = 'i=5006',
   Tanque1_BombaTanque = 'i=5003',
   Tanque1_ControleVazao = 'i=5004'
}

export enum ObjectTypeIds {
   BombaType = 'i=1003',
   ControleType = 'i=1004',
   SensorType = 'i=1005',
   TanqueType = 'i=1006'
}

export enum VariableIds {
   Tanque1_BombaTanque_DL = 'i=6015',
   Tanque1_BombaTanque_EN = 'i=6016',
   Tanque1_BombaTanque_LG = 'i=6017',
   Tanque1_BombaTanque_ST = 'i=6018',
   Tanque1_BombaTanque_TRIP = 'i=6020',
   Tanque1_BombaTanque_VAL = 'i=6021',
   Tanque1_BombaTanque_YS = 'i=6025',
   Tanque1_ControleVazao_MV = 'i=6036',
   Tanque1_ControleVazao_PV = 'i=6037',
   Tanque1_ControleVazao_SP = 'i=6038'
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